using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;
using MegaDesk;
using System.IO;

namespace MegaDesk
{
    internal class DeskQuote
    {
        private static string file = "Desks.txt";

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

        private float calculatePrice(
            int width, int depth, int drawers,
            DesktopMaterial material,int order
            )
        {
            float price = 200;
            price += 50 * drawers;

            int surfaceArea = width * depth;

            if (surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                price += surfaceArea - 1000;
                switch (order)
                {
                    case 3:
                        price += 70; break;
                    case 5:
                        price += 50; break;
                    case 7:
                        price += 35; break;
                }
            }
            else if (surfaceArea > 2000)
            {
                price += surfaceArea - 1000;
                switch (order)
                {
                    case 3:
                        price += 80; break;
                    case 5:
                        price += 60; break;
                    case 7:
                        price += 40; break;
                }
            }
            else
            {
                switch (order)
                {
                    case 3:
                        price += 60; break;
                    case 5:
                        price += 40; break;
                    case 7:
                        price += 30; break;
                }
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
