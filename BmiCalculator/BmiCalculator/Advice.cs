using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BmiCalculator
{
    class Advice:Button
    {
        public List<string> AdviceList = new List<string>();
        private int  _value;
        public int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                if (_value < 0)
                    _value = 11;
                else if (_value > 11)
                    _value = 0;
                if (_value == 0)
                    Text = "Kattints ide tanácsokért!";
                else
                    Text = AdviceList[_value].ToString();
            }
        }

        public Advice()
        {
            Height = 50;
            Width = Height * 2;
            BackColor = Color.White;
            Value = 0;
            MouseDown += Advice_MouseDown;

            AdviceList.Add("A fogyás mértéke ne legyen több mint heti 1 kg. Havonta méressünk testzsír-arányt.");
            AdviceList.Add("Legyen étkezésünk mértékletes, változatos.");
            AdviceList.Add("Naponta ötször, kis adagokban étkezzünk.");
            AdviceList.Add("Csökkentsük a telített zsírtartalmú ételek - vaj, húsételek, vajkrémes sütemények - fogyasztását.");
            AdviceList.Add("Kerüljük a szélsőséges diétásprogramokat.");
            AdviceList.Add("Ne alkalmazzunk gyógyszert vagy boszorkányfőzetet, de a bőséges folyadék-fogyasztásra figyeljünk oda, hiszen mindennek a víz az alapja");
            AdviceList.Add("Kerüljük a cukorfogyasztást, helyette komplex szénhidrátokat - zöldségeket és gyümölcsöket - fogyasszunk.");
            AdviceList.Add("Emeljük a rostbevitelt zöldség, gyümölcs, zabkorpa formájában.");
            AdviceList.Add("Fogyasszunk több Omega-3 zsírsavat, például halakat, tengeri herkentyűket, lenmagot, diót.");
            AdviceList.Add("Növeljük a kondicionáló edzések számát! Végezzünk gyakorlatot kis súlyokkal, nagy ismétlésszámban vagy válasszunk alakformáló tornát. Ezzel az izomrostok közötti zsír csökkenthető.");
            AdviceList.Add("Végezzünk minden nap alacsony intenzitású, hosszan tartó aerob edzést! Ilyen például a kocogás, gyaloglás, kerékpározás, evezés, úszás. Ezzel elérhető a bőr alatti zsírréteg csökkentése.");
            AdviceList.Add("Legjobb a reggeli testmozgás, mivel utána még 18 órán keresztül magasabb az alapanyagcsere.");
        }

        private void Advice_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Value++;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Value--;
            }

        }

    }
}
