﻿using WebLuto.Models;

namespace WebLuto.Services.Interfaces
{
    public interface IClientService
    {
        Task<List<Client>> GetAllClients();

        Task<Client> GetClientById(long id);

        Task<Client> GetClientByEmail(string email);

        Task<Client> CreateClient(Client clientToCreate);

        Task<Client> UpdateClient(Client clientToUpdate, Client existingClient);

        Task<bool> DeleteClient(Client clientToDelete);

        void UpdateIsConfirmed(Client client, bool isConfirmed);

        bool VerifyIsConfirmed(Client client);
    }
}
