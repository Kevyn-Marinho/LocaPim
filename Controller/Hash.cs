using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Business
{
    class Hash
    {
        private HashAlgorithm _algoritmo;

        public Hash(HashAlgorithm algoritmo)
        {
            _algoritmo = algoritmo;
        }

        public string CriptografarSenha(string senha)
        {
            var encodedValue = Encoding.UTF8.GetBytes(senha);
            var encryptedPassword = _algoritmo.ComputeHash(encodedValue);

            var sb = new StringBuilder();
            foreach (var caracter in encryptedPassword)
            {
                sb.Append(caracter.ToString("X2"));
            }

            return sb.ToString();
        }

        public bool VerificarSenha(string senhaDigitada, string senhaCadastrada)
        {
            if (string.IsNullOrEmpty(senhaCadastrada))
                throw new NullReferenceException("Cadastre uma senha.");
            
            String senha = CriptografarSenha(senhaDigitada);

            return senha.Equals(senhaCadastrada);
        }   

    }
}
