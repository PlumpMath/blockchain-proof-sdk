/*
 * Blockchain Proof
 * <b>With the Blockchain Proof API it is easy to prove or disprove existence of (binary) data at a certain point in time. Behind the scenes it stores entries using the Factom (bitcoin), Multichain or Ethereum blockchain by means of our generic blockchain API.</b>    The flow is generally as follows:  1. Make sure a configuration is present  2. Register content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing  3. Verify content by uploading a file, some content, or providing a Stream Location from the Storage API. When you upload content you have to tell the API whether the data has already been hashed or not. If not, or when uploading a file or stream location, the API will take care of the hashing. You will get back whether the content has been registered previously or not      <b>Interactive testing: </b>A web based test console is available in the <a href=\"https://store.sphereon.com\">Sphereon API Store</a>
 *
 * OpenAPI spec version: 0.9
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.sphereon.sdk.blockchain.proof.api;

import com.sphereon.sdk.blockchain.proof.handler.ApiException;
import com.sphereon.sdk.blockchain.proof.model.ContentRequest;
import com.sphereon.sdk.blockchain.proof.model.ErrorResponse;
import java.io.File;
import com.sphereon.sdk.blockchain.proof.model.StreamLocation;
import com.sphereon.sdk.blockchain.proof.model.VerifyContentResponse;
import org.junit.Test;
import org.junit.Ignore;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

/**
 * API tests for VerificationApi
 */
@Ignore
public class VerificationApiTest {

    private final VerificationApi api = new VerificationApi();

    
    /**
     * Verify content
     *
     * 
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void verifyUsingContentTest() throws ApiException {
        String configName = null;
        ContentRequest existence = null;
        VerifyContentResponse response = api.verifyUsingContent(configName, existence);

        // TODO: test validations
    }
    
    /**
     * Verify content using Stream Locations from the Storage API
     *
     * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void verifyUsingLocationTest() throws ApiException {
        String configName = null;
        List<StreamLocation> streamLocations = null;
        VerifyContentResponse response = api.verifyUsingLocation(configName, streamLocations);

        // TODO: test validations
    }
    
    /**
     * Verify content using a bytestream/file
     *
     * Verify content by supplying a file or some other binary data. Hashing will be done on the server side
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void verifyUsingStreamTest() throws ApiException {
        String configName = null;
        File stream = null;
        VerifyContentResponse response = api.verifyUsingStream(configName, stream);

        // TODO: test validations
    }
    
}
