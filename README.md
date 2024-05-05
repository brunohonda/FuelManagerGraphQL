# FuelManagerGrapQL

Bruno de Alcantara Honda
Matrícula: 197545 | Código de Pessoa: 612223

Tarefa prática 3

## Consultas

Consultas geradas para as entidades

### Veiculos

```graphql
query getVeiculos {
  veiculos {
    id
    marca
    modelo
    placa
    anoFabricacao
    anoModelo
    consumos {
      id
      data
      valor
      tipo
    }
  }
}

query getVeiculoById {
  veiculos(where: { id: { eq: 1 } }) {
    id
    marca
    modelo
    placa
    anoFabricacao
    anoModelo
  }
}

query getVeiculoByMarca {
  veiculos(where: { marca: { eq: "Fiat" } }, order: [{ modelo: ASC }]) {
    id
    marca
    modelo
    placa
    anoFabricacao
    anoModelo
  }
}

query getVeiculoWithConsumo {
  veiculos(where: { consumos: { any: true } }, order: [{ modelo: ASC }]) {
    id
    marca
    modelo
    placa
    anoFabricacao
    anoModelo
  }
}

query getVeiculoWithoutConsumo {
  veiculos(where: { consumos: { any: false } }, order: [{ modelo: ASC }]) {
    id
    marca
    modelo
    placa
    anoFabricacao
    anoModelo
  }
}
```

### Cosnumos

```graphql
query getConsumos {
  consumos {
    id
    data
    valor
    tipo
    veiculo {
      id
      marca
      modelo
      placa
      anoFabricacao
      anoModelo
    }
  }
}

query getConsumoById {
  consumos(where: { id: { eq: 1 } }) {
    id
    data
    valor
    tipo
  }
}

query getConsumoByTipo {
  consumos(where: { tipo: { eq: GASOLINA } }, order: [{ data: ASC }]) {
    id
    data
    valor
    tipo
  }
}

query getConsumoByValorLte100 {
  consumos(where: { valor: { lte: 100 } }, order: [{ data: ASC }]) {
    id
    data
    valor
    tipo
  }
}

query getConsumoByValorGt100 {
  consumos(where: { valor: { gt: 100 } }, order: [{ data: ASC }]) {
    id
    data
    valor
    tipo
  }
}
```
