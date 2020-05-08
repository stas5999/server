export type Exception = {
  message: string;
  propertyName: string;
};

export type ServerError = {
  status: number;
  message: string | null;
  errors: Exception[];
};
