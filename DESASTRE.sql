use sl_base;
ALTER TABLE Usuario add foreign key (IdMunicipio) REFERENCES Municipio(IdMunicipio);  
GO 