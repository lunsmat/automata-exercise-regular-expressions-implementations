// classes/Validators/QuestionOne/MailValidator.cs
using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class MailValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^[a-z]+\@[a-z]+(\.com)?\.br$";
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
