// classes/Validators/QuestionOne/PasswordValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class PasswordValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8}$";
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
