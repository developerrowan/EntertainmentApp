import { Star } from '../interfaces/Star';

export function calculateStars(voteAverage: number): Star[] {
    const result: Star[] = [];
    let starClass: string = 'bi-star';

    const rating: number = (voteAverage / 20) * 10;

    for (let i = 1; i < 6; i++) {
      if (i <= rating) {
        starClass = 'bi-star-fill text-warning';
      } else if (i - rating <= 0.5) {
        starClass = 'bi-star-half text-warning';
      } else {
        starClass = 'bi-star';
      }

      result.push({
        index: i,
        class: starClass
      });
    }

    return result;
}