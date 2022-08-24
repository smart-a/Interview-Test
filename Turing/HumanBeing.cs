namespace Turing
{
    public class HumanBeing
    {
        string _name;
        string _sex;
        int _age;
        double _height;
        string _eyesColor;
        string _complexion;
        
        public string Surname { get; set; }

        public HumanBeing(string name, string sex, int age, double height, string eyesColor, string complexion)
        {
            _name = name;
            _sex = sex;
            _age = age;
            _height = height;
            _eyesColor = eyesColor;
            _complexion = complexion;
        }

        public string GetDetails()
        {
            return $"Name: {_name} Sex: {_sex} Age: {_age} Height: {_height}" +
                   $" Eyes Color: {_eyesColor} Complexion: {_complexion}";
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetComplexion()
        {
            return _complexion;
        }

        public int GetAge()
        {
            return _age;
        }

        public double GetHeight()
        {
            return _height;
        }
        
        
    }
}