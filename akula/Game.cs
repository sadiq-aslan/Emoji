using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Game
    {
        public int time;
        public int score=0;
        public void easy() {

            time = 12;
        }
        public void medium() {

            time = 10;
           
        }
        public void hard() {
            time = 7;
        }
    }
}
