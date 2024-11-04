namespace WorkerService1.Services
{
    public class CnpjValidator
    {
        public static bool IsValidCnpj(string cnpj)
        {
            // Tirando caracteres especiais
            string cleanedCnpj = new string(cnpj.Where(char.IsDigit).ToArray());

            // Verificando o comprimento
            if (cleanedCnpj.Length != 14)
            {
                return false;
            }

            // Verifica se todos os dígitos estao iguais
            if (cleanedCnpj.All(c => c == cleanedCnpj[0]))
            {
                return false;
            }

            // Calcula e verifica os dígitos verificadores
            return ValidateDigits(cleanedCnpj);
        }

        private static bool ValidateDigits(string cnpj)
        {
            // Cálculo do primeiro dígito 
            int[] weights1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum1 = weights1.Select((weight, index) => weight * (cnpj[index] - '0')).Sum();
            int remainder1 = (sum1 % 11);
            int firstDigit = (remainder1 < 2) ? 0 : 11 - remainder1;

            // Cálculo do segundo dígito
            int[] weights2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int sum2 = weights2.Select((weight, index) => weight * (cnpj[index] - '0')).Sum();
            int remainder2 = (sum2 % 11);
            int secondDigit = (remainder2 < 2) ? 0 : 11 - remainder2;

            // Verifica se os dígitos verificadores são iguais aos informados
            return cnpj.EndsWith($"{firstDigit}{secondDigit}");
        }
    }
}