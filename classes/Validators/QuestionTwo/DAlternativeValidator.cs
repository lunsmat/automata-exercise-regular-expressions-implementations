// classes/Validators/QuestionTwo/DAlternativeValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class DAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(HH|MM)(hm|mh)(h|m){2,}(hm|mh)$";
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
