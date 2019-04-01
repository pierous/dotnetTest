using System.Collections.Generic;

namespace model {

    public class Area {

        private int x;
        private int y;

        public Area(int x, int y) {
            this.x = x;
            this.y = y;
        }


        public bool isOut(int x, int y) {
            return (
                x > this.x || x < 1
                ||
                y > this.y || y < 1
            );
        }

    }

}
