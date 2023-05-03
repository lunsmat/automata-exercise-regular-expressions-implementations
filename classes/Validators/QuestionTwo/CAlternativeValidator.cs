using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class CAlternativeValidator: IValidator
    {
        public string get_regex_pattern()
        {
            return @"^(HM|MH)m(h|m)*h$";
        }

        /**
         * H representa um homem;
         * M representa uma mulher;
         * h representa um filho do sexo masculino (natural ou adotado);
         * m representa uma filha do sexo feminimo (natural ou adotado);
         * A posição relativa de uma letra em relação às demais indica a idade relativa daquele
         * membro da família em relação aos demais (os mais novos estão sempre à direita).
         * Exemplo: a cadeia “MHhmm” representa uma família com um casal heterossexual em que a
         * mulher é mais velha que o homem. Além disso, esse casal possui três filhos, um homem e
         * duas mulheres, sendo que o filho homem é o mais velho dos três
         *
         * c. Casais heterossexuais mais velhos que os filhos, com a filha mais velha mulher e o filho mais novo homem.
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
