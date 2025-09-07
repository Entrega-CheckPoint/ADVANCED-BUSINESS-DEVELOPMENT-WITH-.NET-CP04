# $ADVANCED-BUSINESS-DEVELOPMENT-WITH-.NET-CP04$

## **Objetivo**

Desenvolver uma aplicação ASP.NET Core MVC que gerencie um sistema de
biblioteca.

## **Integrantes**

| Nome                     | RM     |
| ------------------------ | ------ |
| Francesco M Di Benedetto | 557313 |

## **Link do video**

[https://www.youtube.com/watch?v=OvSwL5b10Bs](https://www.youtube.com/watch?v=OvSwL5b10Bs)

## **Como testar**

### 1. _Clone do repositório_

```bash
git clone https://github.com/Entrega-CheckPoint/ADVANCED-BUSINESS-DEVELOPMENT-WITH-.NET-CP04

cd ADVANCED-BUSINESS-DEVELOPMENT-WITH-.NET-CP04
```

### 2. _Subir os containers com docker compose_

```bash
docker compose up -d --build
```

### 3. _Acesse o Swagger para interagir com a API_

[http://localhost:8080/swagger/index.html](http://localhost:8080/swagger/index.html)

### 4. _Exemplos de requisições (POST)_:

```json
{
  "titulo": "O Hobbit",
  "anoPublicacao": 1937,
  "autor": {
    "nome": "J.R.R. Tolkien",
    "nacionalidade": "Britânico"
  }
}
```
