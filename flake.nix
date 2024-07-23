{
  inputs = {
    nixpkgs.url = "github:NixOS/nixpkgs/nixos-unstable";
  };
  outputs = {
    self,
    nixpkgs,
  }: let
    forEachSupportedSystem = f:
      nixpkgs.lib.genAttrs ["x86_64-linux"] (
        system: f nixpkgs.legacyPackages.${system}
      );
  in {
    formatter = forEachSupportedSystem (pkgs: pkgs.alejandra);
    devShells = forEachSupportedSystem (pkgs: let
      selectPackages = pkgs:
        with pkgs; [
          dotnet-sdk_8
          omnisharp-roslyn
          msbuild
          mavproxy
          dos2unix
        ];
    in {
      default = with pkgs;
        mkShell {
          packages = selectPackages pkgs;
          env = {
            DOTNET_ROOT = "${pkgs.dotnet-sdk_8}";
            LD_LIBRARY_PATH = lib.makeLibraryPath [
              fontconfig
              xorg.libX11
              xorg.libXi
              xorg.libICE
              xorg.libSM
              icu
            ];
          };
        };
      fhs =
        (pkgs.buildFHSUserEnv {
          name = "fhs-shell";
          targetPkgs = selectPackages;
        })
        .env;
    });
  };
}
