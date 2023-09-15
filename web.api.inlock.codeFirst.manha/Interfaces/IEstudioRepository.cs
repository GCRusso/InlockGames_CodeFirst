﻿using web.api.inlock.codeFirst.manha.Domains;

namespace web.api.inlock.codeFirst.manha.Interfaces
{
    public interface IEstudioRepository
    {
        List<Estudio> Listar();
        Estudio BuscarPorId(Guid id);
        void Cadastrar(Estudio estudio);
        void Atualizar(Guid id, Estudio estudio);
        void Deletar(Guid id);
        List<Estudio> ListarComJogos();
    }
}