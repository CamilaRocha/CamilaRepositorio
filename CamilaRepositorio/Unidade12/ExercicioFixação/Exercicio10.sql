--Mostra Titulo e autor


Select L.Titulo, L.AnoPublicacao, A.Nome from Livro as L, Autor as A
Where A.Id = L.Autor_Id