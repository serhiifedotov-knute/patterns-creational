using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanInteger {

    abstract class Furniture {

    }

    class Chair : Furniture {

    }
    class Table : Furniture {

    }

    class Wardrobe : Furniture {
    }

    abstract class ElectonicDevices {

    }

    class Teapot : ElectonicDevices {

    }

    class Pichka : ElectonicDevices {
    }

    class IceCamera : ElectonicDevices {

    }

    class Kitchen {
        Furniture[] furnitures;
        ElectonicDevices[] electronicDevices;


        public Kitchen(Furniture[] furnitures, ElectonicDevices[] electronicDevices
            ) {
            this.furnitures = furnitures;
            this.electronicDevices = electronicDevices;
        }
    }

    class KitchenBuilder {

        private Furniture[] furnitures = new Furniture[100];
        private int furnitureCount = 0;
        private ElectonicDevices[] electonicDevices = new ElectonicDevices[100];
        private int electronicDeviceCount = 0;
 

        public static KitchenBuilder Builder() {
            KitchenBuilder builder = new KitchenBuilder();

            return builder;
        }

        public KitchenBuilder AddFurniture(Furniture furniture) {
            furnitures[furnitureCount++] = furniture;
            return this;
        }

        public KitchenBuilder AddChair(int count = 1) {
            for(int i = 0; i < count; i++) {
                this.AddFurniture(new Chair());
            }
            return this;
        }
        public KitchenBuilder AddTable() {
            return this.AddFurniture(new Table());
        }
        public KitchenBuilder AddElectronicDevice(ElectonicDevices electronicDevice) {
            electonicDevices[electronicDeviceCount++] = electronicDevice;
            return this;
        }

        public KitchenBuilder AddTeaPot() {
            return this.AddElectronicDevice(new Teapot());
        }
        public KitchenBuilder AddIceCamera() {
            return this.AddElectronicDevice(new IceCamera());
        }
        


        public Kitchen Build() {
            return new Kitchen(furnitures, electonicDevices);
        }
    }
}
