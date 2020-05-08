import { Log, UserManagerSettings, UserManager } from 'oidc-client';
import { AUTHORITY, ORIGIN } from '../shared/constants';

const settings: UserManagerSettings = {
  authority: AUTHORITY,
  client_id: 'client_id',
  redirect_uri: ORIGIN + '/signin',
  silent_redirect_uri: ORIGIN + '/signin',
  response_type: 'id_token token',
  scope: 'openid wect.api',
  automaticSilentRenew: true,
  post_logout_redirect_uri: ORIGIN,
};

const userManager = new UserManager(settings);
Log.logger = console;
Log.level = Log.INFO;

export default userManager;
