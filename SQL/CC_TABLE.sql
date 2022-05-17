CREATE TABLE CC_Clientes (
  id_Cliente int PRIMARY KEY,
  nome varchar(256),
  cpf char(14),
  data_Nascimento date,
  email varchar(256),
  telefone char(15)
);

CREATE TABLE CC_Funcionarios (
  id_Funcionario int PRIMARY KEY,
  nome varchar(256),
  cpf char(14),
  data_Nascimento date,
  cargo varchar(256)
);

CREATE TABLE CC_Carros (
  id_Carro int PRIMARY KEY,
  marca varchar(256),
  modelo varchar(256),
  ano int,
  quilometragem int,
  cor varchar(256),
  transmissao_Automatica bool,
  combustivel varchar(50),
  valor decimal,
  id_venda int
);

CREATE TABLE CC_Motos (
  id_Moto int PRIMARY KEY,
  marca varchar(256),
  modelo varchar(256),
  ano int,
  quilometragem int,
  cor varchar(256),
  cilindradas int,
  partida varchar(50),
  valor decimal,
  id_venda int
);

CREATE TABLE CC_Vendas (
  id_Venda int PRIMARY KEY,
  formaPagamento varchar(50),
  valor decimal,
  id_Cliente int,
  id_Funcionario int
);

ALTER TABLE CC_Vendas ADD CONSTRAINT fk_Id_Cliente FOREIGN KEY (id_Cliente) REFERENCES CC_Clientes (id_Cliente);

ALTER TABLE CC_Vendas ADD CONSTRAINT fk_Id_Funcionario FOREIGN KEY (id_Funcionario) REFERENCES CC_Funcionarios (id_Funcionario);

ALTER TABLE CC_Motos ADD CONSTRAINT fk_Id_Venda FOREIGN KEY (id_Venda) REFERENCES CC_Vendas (id_Venda);

ALTER TABLE CC_Carros ADD CONSTRAINT fk_Id_Venda FOREIGN KEY (id_Venda) REFERENCES CC_Vendas (id_Venda);

INSERT INTO CC_Clientes Values (1, 'Luiz', '40676699847', '04-30-1998', 'lopachioni@gmail.com', '912345678');
INSERT INTO CC_Funcionarios Values (1, 'Fulano', '45236978521', '09-12-1984', 'Gerente');
INSERT INTO CC_Vendas Values (1, 'Débito', 153900, 1, 1);
INSERT INTO CC_Carros Values (1, 'Honda', 'CIVIC 2.0 16V FLEXONE EX 4P CVT', 2017, 50000, 'Branco', true, 'Flex', 100000, 1);
INSERT INTO CC_Motos Values (1, 'Kawasaki', 'Z900', 2021, 3600, 'Verde-Preto', '900', 'Elétrica', 53900, 1);





