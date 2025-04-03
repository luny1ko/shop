
using DataTier;

namespace LogicTier
{
    public class ТоварнаяПозиация
    {
        private Товар _товар;

        public ТоварнаяПозиация(Товар p)
        {
            _товар = p;
        }
        public string КодТовара
        {
            get { return _товар.Код; }
            set { _товар.Наименование = value; }
        }
        public string НаименованиеТовара
        {
            get { return _товар.Наименование; }
            set { _товар.Наименование = value; }
        }
        public float ЦенаТовара
        {
            get { return _товар.Цена; }
            set { _товар.Цена = value; }
        }
        public int КоличествоТовара
        {
            get { return _товар.Количество; }
            set { _товар.Количество = value; }
        }
        public string ОписаниеТовара
        {
            get { return _товар.Описание; }
            set { _товар.Описание = value; }
        }
        public float СуммарнаяСтоимостьПозиции
        {
            get { return _товар.Цена * _товар.Количество; }
        }
        public string ПредставлениеТовара
        {
            get
            {
                return _товар.Код + ":" + _товар.Наименование
                    + " (" + _товар.Цена.ToString("C") + ")";
            }
        }
    }
}
