using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;

namespace LogicTier
{
    public class Магазин
    {
        private List<ТоварнаяПозиация> _товары = new List<ТоварнаяПозиация>();
        private Товар t;

        public Магазин()
        {
            List<Товар> tmp = ВсеТовары.ПолучитьВсеТовары();
            foreach (var i in tmp)
            {
                _товары.Add(new ТоварнаяПозиация(t));
            }
        }
    

    public List<ТоварнаяПозиация> СписокТоваров
        {
            get { return _товары; }
        }
    public string НаименованиеМагазина
        {
            get { return "Наш магазин"; }
        }
        public float СуммарнаяСтоимость
        {
            get
            {
                return _товары.Sum(p => p.СуммарнаяСтоимостьПозиции);
            }
        }
        public float СуммарноеКоличество
        {
            get
            {
                return _товары.Sum(p => p.КоличествоТовара);
            }
        }
    }
}
