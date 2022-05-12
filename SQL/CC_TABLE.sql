CREATE TABLE "CC_Clientes" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "cpf" char(14),
  "data_Nascimento" date,
  "email" varchar(256),
  "telefone" char(15)
);

CREATE TABLE "CC_Funcionarios" (
  "id" int PRIMARY KEY,
  "nome" varchar(256),
  "cpf" char(14),
  "data_Nascimento" date,
  "cargo" varchar(256)
);

CREATE TABLE "CC_Carros" (
  "id" int PRIMARY KEY,
  "marca" varchar(256),
  "modelo" varchar(256),
  "ano" int,
  "quilometragem" int,
  "cor" varchar(256),
  "transmissao" varchar(50),
  "combustivel" varchar(50),
  "valor" decimal,
  "id_venda" int
);

CREATE TABLE "CC_Motos" (
  "id" int PRIMARY KEY,
  "marca" varchar(256),
  "modelo" varchar(256),
  "ano" int,
  "quilometragem" int,
  "cor" varchar(256),
  "cilindradas" int,
  "partida" varchar(50),
  "valor" decimal,
  "id_venda" int
);

CREATE TABLE "CC_Vendas" (
  "id" int PRIMARY KEY,
  "formaPagamento" varchar(50),
  "valor" decimal,
  "id_Cliente" int,
  "id_Funcionario" int
);

ALTER TABLE "Vendas" ADD FOREIGN KEY ("id_Cliente") REFERENCES "CC_Clientes" ("id");

ALTER TABLE "Vendas" ADD FOREIGN KEY ("id_Funcionario") REFERENCES "CC_Funcionarios" ("id");

ALTER TABLE "Motos" ADD FOREIGN KEY ("id_venda") REFERENCES "CC_Vendas" ("id");

ALTER TABLE "Carros" ADD FOREIGN KEY ("id_venda") REFERENCES "CC_Vendas" ("id");

INSERT INTO "CC_Clientes" Values (1, 'Luiz', '40676699847', '04-30-1998', 'lopachioni@gmail.com', '912345678');
INSERT INTO "CC_Funcionarios" Values (1, 'Fulano', '45236978521', '09-12-1984', 'Gerente');
INSERT INTO "CC_Vendas" Values (1, 'Débito', 153900, 1, 1);
INSERT INTO "CC_Carros" Values (1, 'Honda', 'CIVIC 2.0 16V FLEXONE EX 4P CVT', 2017, 50000, 'Branco', 'Automático', 'Flex', 100000, 1);
INSERT INTO "CC_Motos" Values (1, 'Kawasaki', 'Z900', 2021, 3600, 'Verde-Preto', '900', 'Elétrica', 53900, 1);



