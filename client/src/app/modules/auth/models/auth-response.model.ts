export interface AuthResponse {
  success: boolean;
  userId?: number;
  userName?: string;
  email?: string;
  token?: string;
  message?: string;
}
