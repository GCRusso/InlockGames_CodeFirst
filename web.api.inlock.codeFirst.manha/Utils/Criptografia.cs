namespace web.api.inlock.codeFirst.manha.Utils
{
    //Criar um classe normal
    public static class Criptografia
    {
        /// <summary>
        /// Gera uma Hash a partir de uma senha
        /// </summary>
        /// <param name="senha"> Senha que receberá a criptografia(Hash) </param>
        /// <returns> Senha Criptografada </returns>
        public static string GerarHash(string senha)
        {
            return BCrypt.Net.BCrypt.HashPassword(senha);
        }

        /// <summary>
        /// Verifica se a hash da senha informada é igual a hash salva no banco
        /// </summary>
        /// <param name="senhaForm"> Senha informada pelo usuário </param>
        /// <param name="SenhaBanco"> Senha cadastrada no banco </param>
        /// <returns> True ou false (Se a senha é verdadeira ?) </returns>
        public static bool CompararHash(string senhaForm, string SenhaBanco)
        {
            return BCrypt.Net.BCrypt.Verify(senhaForm, SenhaBanco);
        }
    }
}
