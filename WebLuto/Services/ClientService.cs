﻿using WebLuto.Models;
using WebLuto.Repositories.Interfaces;
using WebLuto.Services.Interfaces;

namespace WebLuto.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<List<Client>> GetAllClients()
        {
            try
            {
                return await _clientRepository.GetAllClients();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Client> GetClientById(long id)
        {
            try
            {
                return await _clientRepository.GetClientById(id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Client> GetClientByEmailOrUsername(string emailOrUsername)
        {
            try
            {
                return await _clientRepository.GetClientByEmailOrUsername(emailOrUsername);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Client> CreateClient(Client clientToCreate)
        {
            try
            {
                return await _clientRepository.CreateClient(clientToCreate);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<Client> UpdateClient(Client clientToUpdate, Client existingClient)
        {
            try
            {
                return await _clientRepository.UpdateClient(clientToUpdate, existingClient);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<bool> DeleteClient(Client clientToDelete)
        {
            try
            {
                return await _clientRepository.DeleteClient(clientToDelete);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async void ExistsClientWithUsernameOrEmail(string username, string email)
        {
            Client clientUsername = await GetClientByEmailOrUsername(username);

            if (clientUsername != null)
                throw new Exception($"Já existe um cliente com o username: {username}");

            Client clientEmail = await GetClientByEmailOrUsername(email);

            if (clientEmail != null)
                throw new Exception($"Já existe um cliente com o email: {email}");
        }

        public void UpdateIsConfirmed(Client client, bool isConfirmed)
        {
            try
            {
                _clientRepository.UpdateIsConfirmed(client, isConfirmed);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool VerifyIsConfirmed(Client client)
        {
            try
            {
                if (client != null)
                    return client.IsConfirmed;

                return false;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}