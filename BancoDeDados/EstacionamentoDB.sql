CREATE TABLE movimentacoes (
  id int NOT NULL AUTO_INCREMENT,
  id_veiculo int DEFAULT NULL,
  data_entrada timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  data_saida timestamp NULL DEFAULT NULL,
  situacao bit(1) DEFAULT NULL,
  valor decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (id),
  foreign key(id_veiculo) references veiculos(id)
) ;



CREATE TABLE veiculos (
  id int NOT NULL AUTO_INCREMENT,
  placa varchar(7) NOT NULL,
  modelo varchar(12) NOT NULL,
  tipo_veiculo int NOT NULL,
  PRIMARY KEY (id) 
) ;
