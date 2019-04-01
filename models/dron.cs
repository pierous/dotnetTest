using enums;

namespace model {

    public class Drone {

        public int x;
        public int y;
        private Orientation oriented;
        public bool isOut { get; set; }
        private Area area;

        public Drone(int x, int y, Orientation oriented, Area area) {
            this.x = x;
            this.y = y;
            this.oriented = oriented;
            this.area = area;
            this.isOut = this.area.isOut(this.x, this.y);
        }

        private void turn(Direction direction) {
            switch(direction) {
                case Direction.Right:
                    this.oriented = ((int)this.oriented + 1) != 5 ? this.oriented + 1 : Orientation.N;
                    break;
                case Direction.Left:
                    this.oriented = ((int)this.oriented - 1) != 0 ? this.oriented - 1 : Orientation.W;
                    break;
            }
        }

        private void move() {
            switch(this.oriented) {
                case Orientation.N:
                    this.y = this.y + 1;
                    break;
                case Orientation.S:
                    this.y = this.y - 1;
                    break;
                case Orientation.E:
                    this.x = this.x + 1;
                    break;
                case Orientation.W:
                    this.x = this.x - 1;
                    break;
            }
            
            this.isOut = this.area.isOut(this.x, this.y);
        }

        public void run(string way) {
            foreach (var item in way.ToCharArray())
            {
                if (item.Equals('M')) {
                    this.move();
                    if (this.isOut) {
                        break;
                    }
                } else {
                    this.turn((Direction)item);
                }
            }
        }

        public string getPosition() {
            return (this.isOut) ? "OUT" : (
                this.x.ToString() + " " +
                this.y.ToString() + " " +
                this.oriented
                );
        }

    }
}