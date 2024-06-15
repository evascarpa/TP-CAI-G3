namespace Grupo3.Entidades
{
    public class Item
    {
        String _id;
        String _valor;

        public Item(string id, string valor)
        {
            _id = id;
            _valor = valor;
        }
        public string Id { get => _id; set => _id = value; }
        public string Valor { get => _valor; set => _valor = value; }

        public override string ToString()
        {
            return Valor;
        }
    }

}
