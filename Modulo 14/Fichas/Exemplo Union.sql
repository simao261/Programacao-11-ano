SELECT
  p.Designacao AS Produto,
  p.Preco,
  'Iogurtes' AS Categoria
FROM produtos p
JOIN categorias c ON p.Categoria_ID = c.ID
WHERE c.Designacao = 'Iogurtes'

UNION

SELECT
  p.Designacao AS Produto,
  p.Preco,
  'Limpeza' AS Categoria
FROM produtos p
JOIN categorias c ON p.Categoria_ID = c.ID
WHERE c.Designacao = 'Limpeza';
