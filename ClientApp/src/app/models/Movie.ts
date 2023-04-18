export interface Movie {
    id: number;
    adult: boolean;
    backdrop_path?: string;
    original_language?: string;
    original_title?: string;
    overview?: string;
    popularity: number;
    poster_path?: string;
    releaseDate: Date;
    title?: string;
    video: boolean;
    vote_average: number;
    vote_count: number;
}