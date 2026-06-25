
CREATE TABLE TBUsuario (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Username VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(255) NOT NULL
);

CREATE TABLE TBPlano (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Tipo INT NOT NULL,
    Valor DECIMAL(10,2) NOT NULL,
    TempoMeses INT NOT NULL
);

CREATE TABLE TBArtista (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    UsuarioId UNIQUEIDENTIFIER NOT NULL,
    Nome VARCHAR(150) NOT NULL,
    Bio VARCHAR(1000),

    CONSTRAINT FK_Artista_Usuario
        FOREIGN KEY (UsuarioId)
        REFERENCES TBUsuario(Id)
);

CREATE TABLE TBMusica (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Titulo VARCHAR(200) NOT NULL,
    Album VARCHAR(200),
    Duracao DECIMAL(5,2),
    TotalOuvintes INT,
    ArtistaId UNIQUEIDENTIFIER NOT NULL,

    CONSTRAINT FK_Musica_Artista
        FOREIGN KEY (ArtistaId)
        REFERENCES TBArtista(Id)
);

CREATE TABLE TBPlaylist (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    Nome VARCHAR(200) NOT NULL,
    UsuarioId UNIQUEIDENTIFIER NOT NULL,

    CONSTRAINT FK_Playlist_Usuario
        FOREIGN KEY (UsuarioId)
        REFERENCES TBUsuario(Id)
);

CREATE TABLE TBPlaylistMusica (
    PlaylistId UNIQUEIDENTIFIER NOT NULL,
    MusicaId UNIQUEIDENTIFIER NOT NULL,

    PRIMARY KEY (PlaylistId, MusicaId),

    CONSTRAINT FK_PlaylistMusica_Playlist
        FOREIGN KEY (PlaylistId)
        REFERENCES TBPlaylist(Id),

    CONSTRAINT FK_PlaylistMusica_Musica
        FOREIGN KEY (MusicaId)
        REFERENCES TBMusica(Id)
);

CREATE TABLE TBAssinatura (
    Id UNIQUEIDENTIFIER PRIMARY KEY,
    UsuarioId UNIQUEIDENTIFIER NOT NULL,
    PlanoId UNIQUEIDENTIFIER NOT NULL,
    DataInicio DATE NOT NULL,
    DataFim DATE,
    Ativa BIT NOT NULL,

    CONSTRAINT FK_Assinatura_Usuario
        FOREIGN KEY (UsuarioId)
        REFERENCES TBUsuario(Id),

    CONSTRAINT FK_Assinatura_Plano
        FOREIGN KEY (PlanoId)
        REFERENCES TBPlano(Id)
);
