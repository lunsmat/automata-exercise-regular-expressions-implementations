// classes/Validators/QuestionTwo/GAlternativeValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class GAlternativeValidator: IValidator
    {
        private int x = 0;
        private int y = 0;

        public GAlternativeValidator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public string get_regex_pattern()
        {
            return $"^(H|M){"{" + this.x + "," + this.y + "}"}((h|m){"{0,2}"}|(h*m*)*mh{"{0,2}"})$";
        }

        public bool validate(string arg)
        {
            Regex validator = new Regex(
                this.get_regex_pattern(),
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
