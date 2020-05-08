import moment, { Moment } from 'moment';

export const isEmptyObj = (obj: any) => {
  for (const key in obj) {
    if (Object.prototype.hasOwnProperty.call(obj, key) && obj[key]) {
      return false;
    }
  }
  return true;
};

export function removeEmptyProps(obj: any) {
  return Object.keys(obj)
    .filter(
      (f) =>
        Number.isInteger(obj[f]) ||
        (!!obj[f] && obj[f].length > 0) ||
        (obj[f] instanceof Object && !isEmptyObj(obj[f])) ||
        typeof obj[f] === 'boolean'
    )
    .reduce((r: any, i) => {
      r[i] = obj[i];
      return r;
    }, {});
}

export function formatDate(date: Moment) {
  if (date === null) {
    return '-';
  }
  return moment(date).format('DD-MM-YYYY');
}
