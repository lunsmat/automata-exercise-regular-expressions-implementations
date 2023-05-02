using System.Text.RegularExpressions;
using Classes.Validators;

namespace Classes.Validators.QuestionOne
{
    class PasswordValidator: IValidator
    {
        /**
         * Senha:
         * 1. Sentenças podem conter símbolos de Σ∪Γ∪N
         * 2. Sentenças devem ter pelo menos um símbolo de Γ e outro de N
         * 3. Sentenças devem ter comprimento igual a 8
         * Ex. de sentenças aceitas: 518R2r5e, F123456A, 1234567T, ropsSoq0
         * Ex. de cadeias rejeitadas: F1234567A, abcdefgH, 1234567HI
         * Obs.: nesta linguagem é permido utilizar recursos da linguagem de programação (e.g., size,
         * length ou lookahead) para descobrir se a cadeia tem comprimento 8.
         */
        public bool validate(string arg)
        {
            Regex validator = new Regex(
                @"^(?=.*[A-Z])(?=.*[0-9])[a-zA-Z0-9]{8}$",
                RegexOptions.Compiled
            );

            Match matcher = validator.Match(arg);

            return matcher.Success;
        }
    }
}
