import requests
from requests_aws4auth import AWS4Auth
import json

class ServiceAWS:
    def __init__(self, access_key, secret_key, region):
        self.access_key = access_key
        self.secret_key = secret_key
        self.region = region

    def request(self, method, url,serviceName, **kwargs):
        # print(self.access_key)
        # print(self.secret_key)
        # print(self.region)
        # print(serviceName)
        auth = AWS4Auth(self.access_key, self.secret_key, self.region,serviceName)
        try:
            response = requests.request(method, url, auth=auth, **kwargs)
            response.raise_for_status()
            return response.json()
        except requests.exceptions.HTTPError as e:
            if 400 <= e.response.status_code < 500:
                raise ValueError(f'Client Error: {e.response.status_code} {e.response.reason}')
            elif 500 <= e.response.status_code < 600:
                raise ValueError(f'Server Error: {e.response.status_code} {e.response.reason}')
            else:
                raise