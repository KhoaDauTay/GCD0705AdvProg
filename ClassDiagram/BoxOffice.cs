using System.Collections.Generic;

namespace ClassDiagram
{
	internal class BoxOffice
	{
	}

	internal class MovieTheater
	{
		private List<Movie> Movies;
		private BoxOffice BoxOffice;

		public MovieTheater(List<Movie> movies)
		{
			BoxOffice = new BoxOffice();
			Movies = movies;
		}
	}

	internal class Movie
	{
		private List<MovieTheater> MovieTheaters;

		public Movie(List<MovieTheater> movieTheaters)
		{
			MovieTheaters = movieTheaters;
		}
	}
}