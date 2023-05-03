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

        /**
         * E-mail:
         * 1. Sentenças devem conter um, e apenas um, símbolo “@”
         * 2. Excetuando o símbolo “@”, as sentenças possuem apenas símbolos de Σ
         * 3. Sentenças não devem começar com o símbolo “@”
         * 4. Sentenças devem terminar com a subcadeia “.com.br” ou “.br”
         * 5. Sentenças devem ter, pelo menos, um símbolo de Σ entre o símbolo “@” e a
         * subcadeia “.com.br” ou a subcadeia “.br”
         * Ex. de sentenças aceitas: a@a.br, divulga@ufpa.br, a@a.com.br
         * Ex. de cadeias rejeitadas: @, a@.br, @a.br, T@teste.br, a@A.com.br
         */
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
