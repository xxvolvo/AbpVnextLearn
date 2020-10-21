import { Config } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'leanr',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44394',
    redirectUri: baseUrl,
    clientId: 'leanr_App',
    responseType: 'code',
    scope: 'offline_access leanr',
  },
  apis: {
    default: {
      url: 'https://localhost:44394',
      rootNamespace: 'yxyl.leanr',
    },
  },
} as Config.Environment;
