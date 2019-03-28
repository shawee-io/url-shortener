## Algorithm

Basicaly, we store the URL in database, so it has a numeric ID, an we convert it to a another base in order to have a "stringified" version of the ID.

When we have the short URL the process is:
- convert the "stringified" ID to the numeric ID.
- load the data from DB.
- redirect to the original URL using an HTTP redirection.

More theory here in [this stackoverflow topic](https://stackoverflow.com/questions/742013/how-to-code-a-url-shortener).

## Usage

The projet is using SQLite as DB backed. The data file is named `urlshortener.db` by default. To create the data file use the command `dotnet ef database update`, them run the project with `dotnet run`.

Make a post to http://localhost:5000/ShortUrls with a URL in JSON on body to create a new short url. And Make a GET to http://localhost:5000/ShortUrls/{shortURL} to redirect to original URL.