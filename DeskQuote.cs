using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using MegaDesk;
using System.IO;
using System.Collections;
using System.Reflection;

namespace MegaDesk
{
    internal class DeskQuote
    {
        private static string file = "Desks.txt";
        private const String RUSH_ORDER_FILE = "rushOrderPrices.txt";

        public int width;
        public int depth;
        public int drawers;

        public int order;
        public DesktopMaterial material;
        public string customerName;

        public DateTime date;
        public float price;

        public override string ToString()
        {
            return (
                $"Width: {this.width}, Depth: {this.depth}, "+
                $"Drawers: {this.drawers}\n"+
                $"Order: {this.order}, Material: {this.material}\n"+
                $"Name: {this.customerName}, Price: {this.price}"
                );
        }

        public DeskQuote
        (
            int width, int depth, int drawers,
            int order, DesktopMaterial material,
            string customerName, DateTime? date = null
        )
        {
            this.width = width;
            this.depth = depth;
            this.drawers = drawers;

            this.order = order;
            this.material = material;
            this.customerName = customerName;
            this.date = date ?? DateTime.Now;
            this.price = calculatePrice(width, depth, drawers, material, order);
        }

        private Dictionary<int, int[]> getRushOrderPrices()
        {
            Dictionary<int, int[]> ret = new Dictionary<int, int[]>();
            String[] lines =File.ReadAllLines( RUSH_ORDER_FILE );
            var three = new int[] { Int32.Parse(lines[0]), Int32.Parse(lines[1]), Int32.Parse(lines[2]) };
            var five = new int[] { Int32.Parse(lines[3]), Int32.Parse(lines[4]), Int32.Parse(lines[5]) };
            var seven =  new int[] { Int32.Parse(lines[6]), Int32.Parse(lines[7]), Int32.Parse(lines[8]) };
            ret[14] =  new int[] { 0, 0, 0 };
            ret[3] = three;
            ret[5] = five;
            ret[7] = seven;
            return ret;
        }
        private float calculatePrice(
            int width, int depth, int drawers,
            DesktopMaterial material,int order
            )
        {
            float price = 200;
            price += 50 * drawers;

            int surfaceArea = width * depth;
            Dictionary<int, int[]> rushOrderPrices = getRushOrderPrices();

            if (surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                price += surfaceArea - 1000;
                price += rushOrderPrices[order][1];
            }
            else if (surfaceArea > 2000)
            {
                price += surfaceArea - 1000;
                price += rushOrderPrices[order][2];
            }
            else
            {
                price += rushOrderPrices[order][0];
            }
            switch (material)
            {
                case DesktopMaterial.Oak:
                    price += 200;
                    break;
                case DesktopMaterial.Laminate:
                    price += 100;
                    break;
                case DesktopMaterial.Pine:
                    price += 50;
                    break;
                case DesktopMaterial.Rosewood:
                    price += 300;
                    break;
                case DesktopMaterial.Veneer:
                    price += 125;
                    break;
            }
            return price;
        }

    }
}
