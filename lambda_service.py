import requests
from requests_aws4auth import AWS4Auth
import json
from serviceAWS import ServiceAWS


class LambdaService(ServiceAWS):
    def __init__(self, access_key, secret_key, region):
        super().__init__(access_key, secret_key, region)

    def get_all_functions(self):
        functions = []
        next_marker = None
        while True:
            url = f'https://lambda.{self.region}.amazonaws.com/2015-03-31/functions'
            if next_marker:
                url += f'?Marker={next_marker}'

            try:
                response = self.request('GET', url,"lambda")
                functions += response['Functions']
                if (response['NextMarker'] != None):
                    next_marker = response['NextMarker']
                else:
                    break
            except ValueError as e:
                print(f'Error fetching functions: {str(e)}')
                break

        return functions