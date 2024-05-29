import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'SonarQubeTest',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44328/',
    redirectUri: baseUrl,
    clientId: 'SonarQubeTest_App',
    responseType: 'code',
    scope: 'offline_access SonarQubeTest',
    requireHttps: true,
  },
  apis: {
    default: {
      url: 'https://localhost:44328',
      rootNamespace: 'SonarQubeTest',
    },
  },
} as Environment;
