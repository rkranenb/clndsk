using StructureMap;

namespace clndsk {

    public static class IoC {

        public static IContainer CreateContainer() {

            return new Container(registry => {
                registry.Scan(scan => {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                });
            });

        }

    }
}
