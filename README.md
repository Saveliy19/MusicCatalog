
# MusicCatalog

## Описание проекта

**MusicCatalog** — это приложение для управления музыкальными данными, такими как песни, альбомы, исполнители и плейлисты. Приложение предоставляет удобный интерфейс для поиска треков по различным критериям, таким как название, жанр, альбом или плейлист.

## Используемые паттерны проектирования

В проекте использовано несколько паттернов объектно-ориентированного проектирования.

### 1. Паттерн Репозиторий (Repository)

Для работы с базой данных используется паттерн **Репозиторий**. Он абстрагирует доступ к данным, предоставляя унифицированный интерфейс для CRUD операций с сущностями, такими как песни, исполнители, альбомы и плейлисты. Это позволяет отделить логику работы с данными от бизнес-логики приложения, что делает код более модульным и простым в сопровождении.

Пример классов репозиториев:
- `SongRepository`
- `ArtistRepository`
- `AlbumRepository`
- `PlayListRepository`

### 2. Паттерн Одиночка (Singleton)

Для репозиториев применяется паттерн **Одиночка (Singleton)**, чтобы обеспечить создание только одного экземпляра каждого репозитория в рамках приложения. Это помогает избежать избыточного создания объектов и улучшает производительность за счёт повторного использования одного экземпляра.

### 3. Паттерн Стратегия (Strategy)

Для поиска треков по разным критериям реализован паттерн **Стратегия (Strategy)**. Это позволяет динамически изменять логику поиска в зависимости от выбранных критериев (название, жанр, плейлист, альбом и т.д.). Классы стратегий инкапсулируют конкретную логику поиска и позволяют легко расширять функциональность, добавляя новые критерии поиска.

Пример классов стратегий:
- `SongNameSearchStrategy`
- `SongGenreSearchStrategy`
- `PlayListSearchStrategy`
- `AlbumNameSearchStrategy`

### 4. Паттерн Строитель (Builder)

Для конструирования сложных объектов, таких как песни, плейлисты и альбомы, используется паттерн **Строитель (Builder)**. Этот паттерн позволяет пошагово создавать сложные объекты, инкапсулируя логику их инициализации и сборки.