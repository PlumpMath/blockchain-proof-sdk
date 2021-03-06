/**
 * Blockchain Proof
 * <b>With the Blockchain Proof API it is easy to prove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin) blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a Proof chain has been created using the /chain POST endpoint beforehand. Normally you only need one or a handful of chains, during the entiry lifetime of your proof solution. This is a relative expensive operation in terms of money.  2. Store proof entries on the proof chain from step 1. The entries will contain the content and metadata you want to store forever on the specified chain.  3. Retrieve an existing entry from the chain to verify or retrieve data      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.1.0
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


package com.sphereon.sdk.blockchain.proof.api;

import com.sphereon.sdk.blockchain.proof.handler.ApiException;
import com.sphereon.sdk.blockchain.proof.model.ContentRequest;
import com.sphereon.sdk.blockchain.proof.model.RegisterContentResponse;
import com.sphereon.sdk.blockchain.proof.model.VndErrors;
import java.io.File;
import com.sphereon.sdk.blockchain.proof.model.VerifyContentResponse;
import org.junit.Test;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for ProofOfExistenceApi
 */
public class ProofOfExistenceApiTest {

    private final ProofOfExistenceApi api = new ProofOfExistenceApi();

    
    /**
     * Register content
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void registerContentTest() throws ApiException {
        String chainId = null;
        ContentRequest existence = null;
        // RegisterContentResponse response = api.registerContent(chainId, existence);

        // TODO: test validations
    }
    
    /**
     * Register content using a bytestream/file
     *
     * Register content by supplying a file or some other binary data. Hashing will be done on the server side
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void registerStreamTest() throws ApiException {
        String chainId = null;
        File stream = null;
        // RegisterContentResponse response = api.registerStream(chainId, stream);

        // TODO: test validations
    }
    
    /**
     * Verify content
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void verifyContentTest() throws ApiException {
        String chainId = null;
        ContentRequest existence = null;
        // VerifyContentResponse response = api.verifyContent(chainId, existence);

        // TODO: test validations
    }
    
    /**
     * Verify content using a bytestream/file
     *
     * Register content by supplying a file or some other binary data. Hashing will be done on the server side
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void verifyStreamTest() throws ApiException {
        String chainId = null;
        File stream = null;
        // VerifyContentResponse response = api.verifyStream(chainId, stream);

        // TODO: test validations
    }
    
}
