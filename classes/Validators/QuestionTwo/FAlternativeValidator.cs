// classes/Validators/QuestionTwo/FAlternativeValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class FAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(HH|MM)m*(hm+)*h?$";
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
