// classes/Validators/QuestionTwo/AAlternativeValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class AAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(HM|MH)(((h*m+){2}(h|m)*)|((h|m)*h+(h|m)*))$";
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
