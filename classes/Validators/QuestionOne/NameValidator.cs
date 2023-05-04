// classes/Validators/QuestionOne/NameValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class NameValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^[A-Z][a-z]+([\s][A-Z][a-z]+)+$";
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
