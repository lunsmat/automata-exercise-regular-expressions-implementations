using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionTwo
{
    class AAlternativeValidator: IValidator
    {
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
         * a. Casais heterossexuais mais velhos que os filhos com pelo menos duas filhas mulheres,
         * ou pelo menos um filho homem, ou ainda pelo menos dois filhos homens e uma filha mulher
         */
        public bool validate(string arg)
        {
            Regex validator = new Regex(
                @"^(HM|MH)(((h*m+){2}(h|m)*)|((h|m)*h+(h|m)*))$",
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
