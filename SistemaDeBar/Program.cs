using System;
using System.Collections.Generic;
using System.Linq;

class Cliente {
    public int Id { get; set; }
    public string Nome { get; set; }
}

class GerenciamentoClientes {
    private List<Cliente> clientes = new List<Cliente>();
    private int proximoId = 1;

    public void AdicionarCliente(string nome) {
        if (clientes.Any(c => c.Nome == nome))
            throw new Exception("Nome do cliente deve ser único.");

        clientes.Add(new Cliente { Id = proximoId++, Nome = nome });
    }

    public List<Cliente> ListarClientes() {
        return clientes;
    }

    public void EditarCliente(int id, string novoNome) {
        var cliente = clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null)
            throw new Exception("Cliente não encontrado.");
        if (clientes.Any(c => c.Nome == novoNome && c.Id != id))
            throw new Exception("Nome do cliente deve ser único.");

        cliente.Nome = novoNome;
    }

    public void ExcluirCliente(int id) {
        var cliente = clientes.FirstOrDefault(c => c.Id == id);
        if (cliente == null)
            throw new Exception("Cliente não encontrado.");

        clientes.Remove(cliente);
    }
}

class Program {
    static void Main() {
        var gerenciamentoClientes = new GerenciamentoClientes();

        gerenciamentoClientes.AdicionarCliente("João");
        gerenciamentoClientes.AdicionarCliente("Maria");

        var clientes = gerenciamentoClientes.ListarClientes();
        foreach (var cliente in clientes) {
            Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome}");
        }

        gerenciamentoClientes.EditarCliente(1, "João Silva");

        gerenciamentoClientes.ExcluirCliente(2);

        clientes = gerenciamentoClientes.ListarClientes();
        foreach (var cliente in clientes) {
            Console.WriteLine($"ID: {cliente.Id}, Nome: {cliente.Nome}");
        }
    }
}
