using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Интерфейсы
{
    public partial class Form1 : Form
    {
        IMoto moto;

        interface IMoto
        {
            void GetInfo(ListBox lb1);
            void SellItem(int count_for_sell);
        }

        class Items : IMoto
        {
            public string firma;
            public int kol;
            public int price;
            public int god;
            public string nomer;
            public int moshnost;

            public Items(string f, int k, int p, int g, int m, string n)
            {
                firma = f;
                kol = k;
                price = p;
                god = g;
                nomer = n;
                moshnost = m;
            }

            public virtual void GetInfo(ListBox lb1)
            {
                lb1.Items.Add("Фирма Мотоцикла: " + firma);
                lb1.Items.Add("Остаток мотоциклов: " + kol.ToString());
                lb1.Items.Add("Цена аренды: " + price.ToString());
                lb1.Items.Add("Мощность мотоцикла" + moshnost.ToString());
                lb1.Items.Add("Год выпуска" + god.ToString());
                lb1.Items.Add("Номер мотоцикла" + nomer.ToString());
            }

            public void SellItem(int count_for_sell)
            {
                throw new NotImplementedException();
            }
        }
    }
} 
