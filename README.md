

 🧾 Sistema de Bar em C#

 📖 Descrição

O **Sistema de Bar** é um projeto desenvolvido em **C# puro**, com o objetivo de gerenciar pedidos, produtos e contas em um ambiente de bar ou restaurante.
O sistema permite o **cadastro de produtos**, **registro de pedidos**, **cálculo automático da conta**, e **fechamento do caixa**.

 🧰 Tecnologias Utilizadas

* **Linguagem:** C# (.NET 6.0 ou superior)
* **Paradigma:** Programação Orientada a Objetos (POO)
* **Ambiente de execução:** Console Application

 ⚙️ Funcionalidades Principais

* Cadastro de produtos (nome, preço, código)
* Registro de pedidos por mesa ou cliente
* Cálculo do valor total da conta
* Fechamento de conta com troco
* Relatório de vendas do dia
* Armazenamento em memória (listas, sem banco de dados)

 🧩 Estrutura do Projeto


SistemaBar/
│
├── Program.cs               # Ponto de entrada principal do sistema
├── Models/
│   ├── Produto.cs           # Classe responsável pelos dados do produto
│   ├── Pedido.cs            # Classe que representa um pedido
│   └── Mesa.cs              # Classe que agrupa os pedidos por mesa
│
├── Services/
│   ├── PedidoService.cs     # Lógica de manipulação de pedidos
│   └── CaixaService.cs      # Controle de fechamento e relatórios
│
└── Utils/
    └── Menu.cs              # Interface de menu no console


 ▶️ Como Executar

1. **Clone o repositório**

  
   git clone https://github.com/seuusuario/sistema-bar-csharp.git
   cd sistema-bar-csharp
 

2. **Compile o projeto**

  
   dotnet build
   

3. **Execute**

  
   dotnet run
   

 📋 Exemplo de Uso


=== SISTEMA DE BAR ===
1 - Cadastrar produto
2 - Registrar pedido
3 - Listar pedidos
4 - Fechar conta
5 - Relatório do dia
0 - Sair
```

 💡 Exemplos de Entrada e Saída

**Entrada:**


Produto: Cerveja
Preço: 10.00
Mesa: 3
Quantidade: 2


**Saída:**


Pedido registrado!
Total da mesa 3: R$20.00



