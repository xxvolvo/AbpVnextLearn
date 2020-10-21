const ENV = {
  dev: {
    apiUrl: 'http://localhost:44394',
    oAuthConfig: {
      issuer: 'http://localhost:44394',
      clientId: 'leanr_App',
      clientSecret: '1q2w3e*',
      scope: 'leanr',
    },
    localization: {
      defaultResourceName: 'leanr',
    },
  },
  prod: {
    apiUrl: 'http://localhost:44394',
    oAuthConfig: {
      issuer: 'http://localhost:44394',
      clientId: 'leanr_App',
      clientSecret: '1q2w3e*',
      scope: 'leanr',
    },
    localization: {
      defaultResourceName: 'leanr',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
