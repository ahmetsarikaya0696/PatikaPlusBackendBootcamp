# TV Series Catalog

This project is a simple C# application that manages a catalog of TV series. It includes details such as the title, production year, genre, airing start year, directors, and the first platform aired.

## Series Class

The `Series` class represents a TV series with the following properties:

- **Ad**: The title of the series.
- **YapimYili**: The year the series was produced.
- **Tur**: The genre of the series (e.g., Comedy, Drama).
- **YayinlanmayaBaslamaYili**: The year the series started airing.
- **Yonetmenler**: A list of directors associated with the series.
- **YayinlandigiIlkPlatform**: The first platform where the series was aired.

## Program Overview

The `Program` class initializes a list of TV series and filters them based on the genre. It specifically filters for comedy series, orders them by title and director, and displays their details.

### Displaying Series Details

The program outputs the details of each comedy series in a formatted manner.