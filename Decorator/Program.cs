using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            HoliDaySell holiDaySell=new HoliDaySell(new Peykan());
            Console.WriteLine("Brand: "+holiDaySell.GetBrand());
            Console.WriteLine("Price: "+holiDaySell.GetPrice());
            Console.WriteLine("Discount: "+holiDaySell.NewPrice());
        }
    }
    //************************************************************
    public interface IVehicle
    {
        string GetBrand();
        int GetPrice();
    }
    //************************************************************
    public class Peykan:IVehicle
    {
        public string GetBrand()
        {
            return "Peykan";
        }

        public int GetPrice()
        {
            return 5600;
        }
    }
    //************************************************************
    public class Perid:IVehicle
    {
        public string GetBrand()
        {
            return "Pride";
        }

        public int GetPrice()
        {
            return 12800;
        }
    }
    //************************************************************
    public abstract class VhicleDecorator:IVehicle
    {
        private IVehicle _vihicle;

        protected VhicleDecorator(IVehicle vhicle)
        {
            _vihicle = vhicle;
        }

        public string GetBrand()
        {
            return  _vihicle.GetBrand();
        }

        public int GetPrice()
        {
            return _vihicle.GetPrice();
        }
    }
    //************************************************************
    public class NomalSell:VhicleDecorator
    {
        public NomalSell(IVehicle vhicle) : base(vhicle)
        {
        }

        public int percentDiscount = 20;

        public int NewPrice()
        {
            return (int) base.GetPrice() * (100 - percentDiscount) / 100;
        }
    }
    //************************************************************
    public class HoliDaySell:VhicleDecorator
    {
        public HoliDaySell(IVehicle vhicle) : base(vhicle)
        {
        }
        public int percentDiscount = 40;

        public int NewPrice()
        {
            return (int)base.GetPrice() * (100 - percentDiscount) / 100;
        }
    }
    //************************************************************


}
