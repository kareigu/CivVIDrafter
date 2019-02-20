using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CivVIDrafter
{
    public class Civs
    {
        //Vanilla civs
        public string[] vanillaCivs = new string[19];

        public void vanilla() {
            vanillaCivs[0] = "American";
            vanillaCivs[1] = "Arabian";
            vanillaCivs[2] = "Aztec";
            vanillaCivs[3] = "Brazilian";
            vanillaCivs[4] = "Chinese";
            vanillaCivs[5] = "Egyptian";
            vanillaCivs[6] = "English";
            vanillaCivs[7] = "French";
            vanillaCivs[8] = "German";
            vanillaCivs[9] = "Greek";
            vanillaCivs[10] = "Indian";
            vanillaCivs[11] = "Japanese";
            vanillaCivs[12] = "Kongolese";
            vanillaCivs[13] = "Norwegian";
            vanillaCivs[14] = "Roman";
            vanillaCivs[15] = "Russian";
            vanillaCivs[16] = "Scythian";
            vanillaCivs[17] = "Spanish";
            vanillaCivs[18] = "Sumerian";
        }

        //Rise & Fall
        public string[] rfCivs = new string[8];

        public void rf() {
            rfCivs[0] = "Cree";
            rfCivs[1] = "Dutch";
            rfCivs[2] = "Georgian";
            rfCivs[3] = "Korean";
            rfCivs[4] = "Mapuche";
            rfCivs[5] = "Mongolian";
            rfCivs[6] = "Scottish";
            rfCivs[7] = "Zulu";
        }



        //Gathering Storm
        public string[] gsCivs = new string[8];

        public void gs() {
            gsCivs[0] = "Canadian";
            gsCivs[1] = "Incan";
            gsCivs[2] = "Hungarian";
            gsCivs[3] = "Mali";
            gsCivs[4] = "Maori";
            gsCivs[5] = "Ottoman";
            gsCivs[6] = "Phoenecian";
            gsCivs[7] = "Swedish";
        }


        //DLC 
        public string[,] dlcCivs = new string[5, 2];

        public void dlc()
        {
            //Poland
            dlcCivs[0, 0] = "Polish";

            //Australia
            dlcCivs[1, 0] = "Australian";

            //Persia & Macedon
            dlcCivs[2, 0] = "Persian";
            dlcCivs[2, 1] = "Macedonian";

            //Nubia
            dlcCivs[3, 0] = "Nubian";

            //Khmer & Indonesia
            dlcCivs[4, 0] = "Khmerian";
            dlcCivs[4, 1] = "Indonesian";

        }
    }
}
